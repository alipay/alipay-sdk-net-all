using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountTokenGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountTokenGenerateModel : AopObject
    {
        /// <summary>
        /// 产品码下的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// token存储有效期,单位秒
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 业务场景标识JOINT_ACCOUNT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 外部传入token值，支付宝侧会基于该token进行转换存储，结果返回基于外部传入token处理转换后的token值
        /// </summary>
        [XmlElement("token_key")]
        public string TokenKey { get; set; }

        /// <summary>
        /// 外部传入需要转为token的明文值，例如跳端加签结果
        /// </summary>
        [XmlElement("token_value")]
        public string TokenValue { get; set; }
    }
}
