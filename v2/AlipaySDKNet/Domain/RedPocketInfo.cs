using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedPocketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RedPocketInfo : AopObject
    {
        /// <summary>
        /// 红包id
        /// </summary>
        [XmlElement("red_pocket_id")]
        public string RedPocketId { get; set; }

        /// <summary>
        /// 红包发送后生成的外部订单号 有行业侧定义  根据外部订单号可查询到对应红包信息
        /// </summary>
        [XmlElement("red_pocket_out_biz_no")]
        public string RedPocketOutBizNo { get; set; }

        /// <summary>
        /// 红包说明/描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 红包发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }
    }
}
