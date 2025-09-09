using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechAppcoreEnergysavingSubmitResponse.
    /// </summary>
    public class DatadigitalAnttechAppcoreEnergysavingSubmitResponse : AopResponse
    {
        /// <summary>
        /// 节能申请信息，节能申请的相关信息给到用户，如用户的申请后的实际节能信息，不是成功或失败
        /// </summary>
        [XmlElement("energy_saving_apply")]
        public string EnergySavingApply { get; set; }
    }
}
