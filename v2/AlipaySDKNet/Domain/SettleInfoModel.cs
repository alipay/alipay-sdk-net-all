using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInfoModel : AopObject
    {
        /// <summary>
        /// 结算账号,一般是手机号或者邮箱
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 结算类型设置,0默认是结算到户,目前只支持结算到户
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
