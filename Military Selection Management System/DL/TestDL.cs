using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Military_Selection_Management_System.BL;
namespace Military_Selection_Management_System.DL
{
	class TestDL
	{
        private List<Test> testList = new List<Test>();
		public addIntoTestList(Test test)
		{
			testList.Add(test);
		}
	}

}

