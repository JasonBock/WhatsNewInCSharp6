using System;
using System.Threading.Tasks;
using System.Windows;
using WhatsNewInCSharp6.Features.Exceptions;
using WhatsNewInCSharp6.Features.Methods;
using WhatsNewInCSharp6.Features.Miscellaneous;
using WhatsNewInCSharp6.Features.Properties;
using WhatsNewInCSharp6.Features.Syntax;

namespace WhatsNewInCSharp6
{
	class Program
	{
		static void Main(string[] args)
		{
			//Program.DemonstrateProperties();
			//Program.DemonstrateMethods();
			//Program.DemonstrateNullConditionalAndStringInterpolation();
			//Program.DemonstrateNameOf();
			//Program.DemonstrateExceptions().Wait();
			Program.DemonstrateMiscellaneous();
		}

		private static void DemonstrateProperties()
		{
			var oldWay = new OldProperties();
			Console.Out.WriteLine("ReadWriteData: " + oldWay.ReadWriteData + ", ReadOnlyData: " + oldWay.ReadOnlyData);
			var newWay = new NewProperties();
			Console.Out.WriteLine("ReadWriteData: " + newWay.ReadWriteData + ", ReadOnlyData: " + newWay.ReadOnlyData);
			var newWayOnCtor = new NewPropertiesOnConstruction();
			Console.Out.WriteLine("ReadWriteData: " + newWayOnCtor.ReadWriteData + ", ReadOnlyData: " + newWayOnCtor.ReadOnlyData);
		}

		private static void DemonstrateMethods()
		{
			var random = new Random();

			Console.Out.WriteLine("Old Way");
			var oldWay = new OldMethods();
			oldWay.Print(Console.Out);
			Console.Out.WriteLine("GetMinimum(): " + oldWay.CalculateMinimum());

			oldWay.SetValues(random.Next(), random.Next());
			oldWay.Print(Console.Out);
			Console.Out.WriteLine("GetMinimum(): " + oldWay.CalculateMinimum());

			Console.Out.WriteLine();

			Console.Out.WriteLine("New Way");
			var newWay = new NewMethods();
			newWay.Print(Console.Out);
			Console.Out.WriteLine("GetMinimum(): " + newWay.CalculateMinimum());

			newWay.SetValues(random.Next(), random.Next());
			newWay.Print(Console.Out);
			Console.Out.WriteLine("GetMinimum(): " + newWay.CalculateMinimum());
		}

		private static void DemonstrateNullConditionalAndStringInterpolation()
		{
			var oldParent = new Parent(new OldChild("John", "Smith", new DateTime(1980, 2, 2)));
			Console.Out.WriteLine("oldParent version: " + oldParent.Child);

			var newParent = new Parent(new NewChild("Jane", "Smith", new DateTime(1990, 3, 3)));
			Console.Out.WriteLine("newParent version: " + newParent.Child);

			var safeParent = new Parent(null);
			Console.Out.WriteLine("safeParent version: " + safeParent.Child);

			try
			{
				Console.Out.WriteLine(safeParent.Child.ToString());
			}
			catch(NullReferenceException)
			{
				Console.Out.WriteLine("NullReferenceException occurred on safeParent.");
			}

			Console.Out.WriteLine("safeParent version with null conditional operator: " + 
				(safeParent.Child?.ToString() ?? "Null reference found."));
		}

		private static void DemonstrateNameOf()
		{
			var parent = new Parent(new NewChild("Jane", "Smith", new DateTime(1990, 3, 3)));

			WeakEventManager<Child, EventArgs>.AddHandler(parent.Child, "ToStringCalled",
				(s, e) => Console.Out.WriteLine("Magic string implementation: ToString was called"));
			WeakEventManager<Child, EventArgs>.AddHandler(parent.Child, nameof(Child.ToStringCalled),
				(s, e) => Console.Out.WriteLine("nameof implementation: ToString was called"));
			Console.Out.WriteLine(parent.Child);

			Console.Out.WriteLine(nameof(parent));
			Console.Out.WriteLine(nameof(parent.Child));
			Console.Out.WriteLine(nameof(INameOf.OverloadedMethod));
			Console.Out.WriteLine(nameof(INameOf.Data));

			// This doesn't work:
			// Console.Out.WriteLine(nameof(INameOfWithGeneric<>.Method<>));
			// Or this:
			// Console.Out.WriteLine(nameof(INameOfWithGeneric<>.Method));
			// Even if I redfined the calling method to "DemonstrateNameOf<T, U>", this wouldn't work either:
			// Console.Out.WriteLine(nameof(INameOfGeneric<T>.Method<U>));
			// But this does:
			Console.Out.WriteLine(nameof(INameOfWithGeneric<int>.Method));

			var nameOf = new NameOfWithGeneric<string>();
			Console.Out.WriteLine(nameof(nameOf.Method));

			Console.Out.WriteLine(nameof(INameOfWithGenericInMethod.Method));
		}

		private static async Task DemonstrateExceptions()
		{
			var horrible = new Horrible(new Logger());
			Console.Out.WriteLine($"Remainder of 10/6 is {await horrible.RemainderAsync(10, 6, false)}");
			Console.Out.WriteLine($"Remainder of 10/0 is {await horrible.RemainderAsync(10, 0, true)}");

			try
			{
				await horrible.RemainderAsync(10, 0, false);
			}
			catch (DivideByZeroException)
			{
				await Console.Out.WriteLineAsync($"Caught in {nameof(Program.DemonstrateExceptions)}");
			}
      }

		private static void DemonstrateMiscellaneous()
		{
			var oldThings = new UsingOldThings();
			Console.Out.WriteLine(oldThings);

			var newThings = new UsingNewThings();
			Console.Out.WriteLine(newThings);
		}
	}

	public interface INameOf
	{
		void OverloadedMethod();
		void OverloadedMethod(string a);
		string Data { get; set; }
   }

	public interface INameOfWithGeneric<T>
	{
		void Method<U>(T a, U b);
	}

	public class NameOfWithGeneric<T>
		: INameOfWithGeneric<T>
	{
		public void Method<U>(T a, U b)
		{
			throw new NotImplementedException();
		}
	}

	public interface INameOfWithGenericInMethod
	{
		void Method<U>(U b);
	}
}
