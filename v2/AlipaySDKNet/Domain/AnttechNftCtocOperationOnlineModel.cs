using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocOperationOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocOperationOnlineModel : AopObject
    {
        /// <summary>
        /// 被转入用户的支付宝uid或手机号
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// ENABLE_TRANSFER(上架) UNABLE_TRANSFER(下架)
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 藏品上下降对象
        /// </summary>
        [XmlArray("tenant_nft_list")]
        [XmlArrayItem("tenant_list_nft_d_t_o")]
        public List<TenantListNftDTO> TenantNftList { get; set; }
    }
}
