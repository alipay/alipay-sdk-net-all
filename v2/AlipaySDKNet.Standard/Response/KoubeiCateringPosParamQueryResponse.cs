using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [XmlElement("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
