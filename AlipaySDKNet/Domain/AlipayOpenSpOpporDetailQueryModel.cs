using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOpporDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOpporDetailQueryModel : AopObject
    {
        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商机作业Id
        /// </summary>
        [XmlElement("oppor_id")]
        public string OpporId { get; set; }
    }
}
