using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Schedule Data Structure.
    /// </summary>
    [Serializable]
    public class Schedule : AopObject
    {
        /// <summary>
        /// 是否开启
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 参数id
        /// </summary>
        [XmlElement("param_id")]
        public long ParamId { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [XmlElement("param_name")]
        public string ParamName { get; set; }

        /// <summary>
        /// 配置 ：类型为【固定周期】时，在该字段填写配置数据
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 配置 ：类型为【Crond配置】时，在该字段填写配置数据
        /// </summary>
        [XmlElement("period_crond_expr")]
        public string PeriodCrondExpr { get; set; }

        /// <summary>
        /// 类型（fixed :固定周期/ period：Crond配置）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
