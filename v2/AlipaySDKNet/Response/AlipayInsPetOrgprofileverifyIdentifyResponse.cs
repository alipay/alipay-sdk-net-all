using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyIdentifyResponse.
    /// </summary>
    public class AlipayInsPetOrgprofileverifyIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 校验结果编号，需要通过校验结果编号查询同宠校验结果
        /// </summary>
        [XmlElement("check_record_no")]
        public string CheckRecordNo { get; set; }
    }
}
