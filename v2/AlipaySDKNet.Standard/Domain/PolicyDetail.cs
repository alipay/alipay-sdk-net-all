using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyDetail : AopObject
    {
        /// <summary>
        /// 扣减比例/金额： ● 扣减类型=1：金额数字，单位：元；如：200 ● 扣减类型=2：百分比数字，如20，表示扣减money_base的20%
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 扣减类型： ● 1-固定金额 ● 2-百分比
        /// </summary>
        [XmlElement("deduct_type")]
        public string DeductType { get; set; }

        /// <summary>
        /// 退票或改签的具体政策描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 扣减基线的描述，可以是一个具体的金额或者短语描述，如「原票价」或「1000（1000是一个票价）」，当给出的扣减类型是固定金额的话，可不传这个
        /// </summary>
        [XmlElement("money_base")]
        public string MoneyBase { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [XmlElement("time_base")]
        public string TimeBase { get; set; }

        /// <summary>
        /// 1:该时间之前 2:该时间之后
        /// </summary>
        [XmlElement("time_base_type")]
        public string TimeBaseType { get; set; }
    }
}
