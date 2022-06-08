using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnvironmentalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnvironmentalDTO : AopObject
    {
        /// <summary>
        /// 一个环保行为实际发放的数量
        /// </summary>
        [XmlElement("energy_amount")]
        public string EnergyAmount { get; set; }

        /// <summary>
        /// 商品对应的环保类型; 字典值: 临时商品: 替换装: FSC:
        /// </summary>
        [XmlElement("environmental")]
        public string Environmental { get; set; }

        /// <summary>
        /// 能量发放失败字典值对应数值 404 406 407 415 701 702 707 N1301
        /// </summary>
        [XmlElement("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// 能量发放失败原因 商户信息不存在 商户签约信息不存在 签约信息不合法 签约状态未上线或用户不再商户的灰度名单中 超出限额 用户关闭授权 业务时间相差太久
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 一个环保行为能量发放状态; "0"代表成功，“-1”代表失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
