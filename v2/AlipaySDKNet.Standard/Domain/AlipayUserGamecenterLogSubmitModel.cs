using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterLogSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterLogSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 通用错误码: RETRY_FAILED - 重试多次仍然失败 DELAY_SUBMIT - 数据将延迟上传  游戏商可自定义不能及时上报的错误码，然后同步给玩一玩技术
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 游戏商自行定义具有可读性的错误码描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 出现异常的openapi接口名字
        /// </summary>
        [XmlElement("openapi_name")]
        public string OpenapiName { get; set; }

        /// <summary>
        /// 出现异常的openapi接口请求参数信息。直接取request中的bizContent字段信息
        /// </summary>
        [XmlElement("request_body")]
        public string RequestBody { get; set; }
    }
}
