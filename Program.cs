using System;
using System.IO;

namespace App {
	class Program {

		/// <summary>
		/// Harness lightning.
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			oParams p = GetOpt(args);
			TextReader cin = p.input == null ? Console.In : new StringReader(p.input);
			if (p.ascii) ToAscii(cin, p.verbose);
			else ToChar(cin, p.verbose);
		}

		/// <summary>
		/// Output characters of input ASCII codes.
		/// </summary>
		/// <param name="cin">Input stream.</param>
		/// <param name="vb">Verbose?</param>
		private static void ToChar(TextReader cin, bool vb) {
			char[] c = new char[256];
			while(true) {
				int v = 0;
				string ln = cin.ReadLine();
				if (ln == null) return;
				if (!int.TryParse(ln, out v) || v < 0 || v > 255) { Console.Write("<ascii? {0}>{1}", ln, vb? "\n" : ""); continue; }
				if (vb) Console.WriteLine("{0} : {1}", ln, (char)v);
				else Console.Write((char)v);
			}
		}

		/// <summary>
		/// Output ASCII codes of input characters.
		/// </summary>
		/// <param name="cin">Input stream.</param>
		/// <param name="vb">Verbose?</param>
		private static void ToAscii(TextReader cin, bool vb) {
			char[] c = new char[256];
			while(true) {
				int R = cin.Read(c, 0, c.Length);
				if (R <= 0) return;
				for (int r = 0; r < R; r++) {
					if (vb) Console.WriteLine("{0} : {1}", c[r] < ' ' ? '.' : c[r], (int)c[r]);
					else Console.WriteLine((int)c[r]);
				}
			}
		}

		/// <summary>
		/// Get input options to echar.
		/// </summary>
		/// <returns>Input options.</returns>
		private static oParams GetOpt(string[] args) {
			oParams o = new oParams();
			for(int i=0; i<args.Length; i++) {
				switch(args[i]) {
					case "-a":
					case "--ascii":
						o.ascii = true;
						break;
					case "-v":
					case "--verbose":
						o.verbose = true;
						break;
					case "-i":
					case "--input":
						o.input = args[++i];
						break;
				}
			}
			return o;
		}
	}
}
