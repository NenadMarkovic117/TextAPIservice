using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    public string GetData(string textValue)
    {
        int TextWordCount = 0, index = 0;

        while (index < textValue.Length && char.IsWhiteSpace(textValue[index]))
            index++;

        while (index < textValue.Length)
        {
            while (index < textValue.Length && !char.IsWhiteSpace(textValue[index]))
                index++;

            TextWordCount++;

            while (index < textValue.Length && char.IsWhiteSpace(textValue[index]))
                index++;
        }

        return string.Format("Word calculate: {0}", TextWordCount);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
