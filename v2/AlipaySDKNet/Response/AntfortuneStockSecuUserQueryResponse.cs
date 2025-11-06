using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockSecuUserQueryResponse.
    /// </summary>
    public class AntfortuneStockSecuUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户证券签约协议号、昵称、头像地址和投资宣言信息组成的对象数组
        /// </summary>
        [XmlArray("secu_user_list")]
        [XmlArrayItem("secu_user_list")]
        public List<SecuUserList> SecuUserList { get; set; }
    }
}
