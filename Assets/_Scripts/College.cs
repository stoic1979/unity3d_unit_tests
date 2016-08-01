using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class College {

	public List<Student> students = new List<Student> ();

	public bool StudentExists(Student student) {
		for (int i = 0; i < students.Count; i++) {
			if (students [i].Equals (student)) {
				return true;
			}
		}
		return false;
	}
		
	public void AddStudent(string name, int standard){

		int rollNo = 0;
		if (students.Count > 0) {
			rollNo = students [students.Count - 1].rollNo + 1;
		}

		Student student = new Student (name, rollNo, standard);

		if (StudentExists (student)) {
			return;
		}

		students.Add (student);
	}
		
	public int GetStudentIndex(int rollNo){
		for (int i = 0; i < students.Count; i++) {
			if (students [i].rollNo == rollNo) {
				return i;
			}
		}

		return -1;
	}
		
	public void RemoveStudent(int rollNo){
		int index = GetStudentIndex (rollNo);

		if (index == -1) {
			return;
		}

		students.RemoveAt (index);
	}

}//CollegeDetails