// cs0139-6.cs: No enclosing loop out of which to break or continue
// Line: 9

class Foo {
	static void Main ()
	{
		try {
		} catch {
			continue;
		} finally {
			throw new System.Exception ();
		}
	}
}
