using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_assignment1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service4" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service4.svc or Service4.svc.cs at the Solution Explorer and start debugging.
	public class Service4 : IService4
	{
		public string htmlOutput(string tag, string data)
		{
			return ("<" + tag + ">" + data + "</" + tag + ">\n");
		}
	}
}
