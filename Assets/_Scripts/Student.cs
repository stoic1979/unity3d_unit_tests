using System;

[Serializable]
public class Student {

	public string name;
	public int rollNo;
	public int standard;

	public Student(string name, int rollNo, int standard){
		this.name = name;
		this.rollNo = rollNo;
		this.standard = standard;
	}

	public override bool Equals (object obj)
	{
		var student = obj as Student;
		if (student == null) {
			return false;
		}
		return name.Equals(student.name) &&
			rollNo == student.rollNo &&
			standard == student.standard ;
	}

}//StudentsRecord