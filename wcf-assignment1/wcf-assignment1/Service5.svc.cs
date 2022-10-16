using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_assignment1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service5" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service5.svc or Service5.svc.cs at the Solution Explorer and start debugging.
	public class Service5 : IService5
	{
		public string sortNumbers(string sortType, string numbers)
		{
			int tmp;
			string returnNums = "";
			try
			{
				int[] nums = Array.ConvertAll(numbers.Split(','), int.Parse);
				

				switch (sortType.ToLower())
				{ 
					case "ascending":

						Array.Sort(nums);

						break;
					case "descending":

						Array.Sort(nums);
						Array.Reverse(nums);
						
						break;
					default:
						return "Invalid inputs.\n";
				}

				foreach (int item in nums)
				{
					returnNums = returnNums + item + ", ";
				}
				returnNums = returnNums.Substring(0,returnNums.Length - 2);
			}
			catch (Exception)
			{
				return "Invalid Input\n";
			}
			return returnNums;
		}
	}
}
