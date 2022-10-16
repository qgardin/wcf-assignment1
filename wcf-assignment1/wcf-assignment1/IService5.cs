using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_assignment1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService5" in both code and config file together.
	[ServiceContract]
	public interface IService5
	{
		[OperationContract]
		string sortNumbers(string sortType, string numbers);
	}
}
