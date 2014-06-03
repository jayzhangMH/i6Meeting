using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Open.MingdaoSDK.Entity
{
    [Serializable]
    [XmlRoot("result")]
    public class ProjectModel
    {
        private string _id;
        [XmlElement("id")]
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        [XmlElement("name")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _Error_Code;
        [XmlElement("error_code")]
        public string Error_Code
        {
            get { return _Error_Code; }
            set { _Error_Code = value; }
        }
    }
}
