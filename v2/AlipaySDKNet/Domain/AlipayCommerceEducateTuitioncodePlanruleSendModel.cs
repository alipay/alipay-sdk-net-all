using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlanruleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodePlanruleSendModel : AopObject
    {
        /// <summary>
        /// 分配类型： 1-平均分配； 2-自定义分配;
        /// </summary>
        [XmlElement("allot_type")]
        public string AllotType { get; set; }

        /// <summary>
        /// 打款规则执行类型： 1-系统调度； 2-外部触发
        /// </summary>
        [XmlElement("execute_type")]
        public string ExecuteType { get; set; }

        /// <summary>
        /// 外部业务编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 周期数。平均分配方式下必填
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 规则设定类型： 1- 课程级别 2-交易级别
        /// </summary>
        [XmlElement("setting_type")]
        public string SettingType { get; set; }

        /// <summary>
        /// 商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
