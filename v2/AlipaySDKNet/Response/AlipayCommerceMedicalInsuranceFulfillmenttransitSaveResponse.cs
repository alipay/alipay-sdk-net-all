using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFulfillmenttransitSaveResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFulfillmenttransitSaveResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("string")]
        public List<string> FailList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("string")]
        public List<string> SuccList { get; set; }
    }
}
