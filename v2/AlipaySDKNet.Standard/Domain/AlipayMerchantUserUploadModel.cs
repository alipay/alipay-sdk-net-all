using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantUserUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantUserUploadModel : AopObject
    {
        /// <summary>
        /// 商家用户列表，注意：上传数量不能大于1000
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("mrch_crm_user")]
        public List<MrchCrmUser> UserList { get; set; }
    }
}
