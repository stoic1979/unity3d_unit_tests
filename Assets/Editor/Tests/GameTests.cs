using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;

public class GameTests {

    [Test]
    public void TestSomeStrings()
    {
		string s1 = "I like Unit tests";
		string s2 = "I LIKE UNIT Tests";

		Assert.AreEqual (s1.ToLower(), s2.ToLower());
    }

	[Test]
	public void TestAdmissionInCollege() {

		var col = new College ();

		col.AddStudent ("Sunny", 5);
		col.AddStudent ("Anna", 4);
		col.AddStudent ("Mike", 5);

		var expected = new List<Student>{ 
			new Student("Sunny", 0, 5),
			new Student("Anna", 1, 4),
			new Student("Mike", 2, 5)
		};

		Assert.AreEqual (expected, col.students);
	}

	[Test]
	public void TestStudentLeavingCollege() {
		var col = new College ();

		col.AddStudent ("Sunny", 5);
		col.AddStudent ("Anna", 5);
		col.AddStudent ("Nitin", 5);
		col.AddStudent ("Vasu", 5);
		col.RemoveStudent (3);
		col.AddStudent ("Mike", 5);
		col.AddStudent ("Nitin",  5);

		var expected = new List<Student>{ 
			new Student("Sunny", 0, 5),
			new Student("Anna", 1, 5),
			new Student("Nitin", 2, 5),
			new Student("Mike", 3, 5),
			new Student("Nitin", 4, 5)
		};

		Assert.AreEqual (expected, col.students);
	}
		
	[Test]
	public void TestStudentLeavingCollege2() {
		var col = new College ();
		col.AddStudent ("Sunny", 5);
		col.AddStudent ("Anna", 5);
		col.AddStudent ("Nitin", 5);
		col.AddStudent ("Vasu", 5);
		col.RemoveStudent (2);
		col.AddStudent ("Mike", 5);
		col.AddStudent ("Nitin",  5);

		var expected = new List<Student>{
			new Student("Sunny", 0, 5),
			new Student("Anna", 1, 5),
			new Student("Vasu", 3, 5),
			new Student("Mike", 4, 5),
			new Student("Nitin", 5, 5)
		};
		Assert.AreEqual (expected, col.students);
	}

}//GameTests