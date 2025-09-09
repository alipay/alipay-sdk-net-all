using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAuthorizeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAuthorizeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询每页最大条数，支持最大100条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 授权类型，不传查所有类型的数据，目前只支持 GROUP_INSTANCE_ADMIN(管理商家的支付宝粉丝群)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户名称（真实姓名）。
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
