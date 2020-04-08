using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenContentContentlibYoukuvideoauditSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenContentContentlibYoukuvideoauditSendModel : AopObject
    {
        /// <summary>
        /// 审核后状态:allowed 审核通 过，blocked 屏蔽驳回， censoring 审核中
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 审核前状态:allowed 审核通 过，blocked 屏蔽驳回， censoring 审核中
        /// </summary>
        [XmlElement("old_action")]
        public string OldAction { get; set; }

        /// <summary>
        /// 审核来源，1表示审核-一审、 2表示审核-二审、3表示审核- 三审、4表示审核-综合审、 5表示审核-修改审， 30表示播 控， 31表示版权解除屏蔽操 作，32VMS解屏蔽,33表示视 频替换 40来疯先发后审 41 表 示来疯审核
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 视频ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
