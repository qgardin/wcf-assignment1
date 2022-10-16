using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1: IService1
	{
		public string checkPrime(int value)
		{
			bool isPrime = true;

			if (value < 2) isPrime = false;
			if (value % 2 == 0) isPrime = false;
			if (value == 2) isPrime = true;
			for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(value)); i += 2)
			{
				if (value % i == 0)
				{
					isPrime = false;
				}
			}

			if(isPrime) return (value + " is a prime number.\n");
			else return (value + " is not a prime number.\n");
		}

	}
}
