public class RotateString{
	public bool RotateString(string s, string goal)
	{
		if (s.Length != goal.Length) return false;
		string n = s + s;
		return n.Contains(goal);
	}