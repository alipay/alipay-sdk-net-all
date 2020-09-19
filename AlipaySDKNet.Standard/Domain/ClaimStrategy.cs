using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimStrategy : AopObject
    {
        /// <summary>
        /// 事故类型事故类型: 1:超时赔付 2:取消赔付 3:商家切自配送赔付
        /// </summary>
        [XmlElement("accident_type")]
        public string AccidentType { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 常量:单位(分)
        /// </summary>
        [XmlElement("constant")]
        public long Constant { get; set; }

        /// <summary>
        /// 赔付区间上限值
        /// </summary>
        [XmlElement("end_section")]
        public long EndSection { get; set; }

        /// <summary>
        /// 最大赔付金额
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 赔付最小金额,单位:分
        /// </summary>
        [XmlElement("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 价格赔付比例(小数点后两位)
        /// </summary>
        [XmlElement("price_ratio")]
        public long PriceRatio { get; set; }

        /// <summary>
        /// 起配时间，单位:分钟
        /// </summary>
        [XmlElement("start_compensation_time")]
        public long StartCompensationTime { get; set; }

        /// <summary>
        /// 赔付区间起始值
        /// </summary>
        [XmlElement("start_section")]
        public long StartSection { get; set; }

        /// <summary>
        /// 时间赔付比例:小数点后2位
        /// </summary>
        [XmlElement("time_ratio")]
        public long TimeRatio { get; set; }
    }
}
