using System;

public struct Student
{
	public int StdID;

	private string Name;



	public Student(int StdID,string Name)
	{
		this.StdID=StdID;
		this.Name=Name;
	}


	public string GetStudent()
	{
		string str;
		str=StdID.ToString();
		str += "" + Name;

		return str;
	}
}
