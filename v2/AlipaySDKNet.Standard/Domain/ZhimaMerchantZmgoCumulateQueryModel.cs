using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantZmgoCumulateQueryModel : AopObject
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。
        /// </summary>
        [XmlElement("need_detail")]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页参数，当need_detail=true时需要，代表当前页数，从1开始。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数，当need_detail=true时需要，代表每页大小，不能大于20。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("provider_pid")]
        public string ProviderPid { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
