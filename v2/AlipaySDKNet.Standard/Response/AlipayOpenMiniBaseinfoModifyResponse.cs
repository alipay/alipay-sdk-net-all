using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoModifyResponse.
    /// </summary>
    public class AlipayOpenMiniBaseinfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 小程序基础信息修改结果，无开发中版本或仅有开发中版本修改立即生效，有上架版本会启动小程序信息审核，审核通过后信息修改生效。
        /// </summary>
        [XmlElement("modify_status")]
        public string ModifyStatus { get; set; }
    }
}
