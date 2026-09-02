using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyConsultResponse.
    /// </summary>
    public class AlipayInsPetOrgprofileverifyConsultResponse : AopResponse
    {
        /// <summary>
        /// "true":"识别为同宠" "false":"识别为非同宠"
        /// </summary>
        [XmlElement("same_pet_result")]
        public string SamePetResult { get; set; }

        /// <summary>
        /// 校验结果的置信度得分，范围是[0,100]的数字，数字越大，置信度越高
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 同宠识别是否完成的标识
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
