using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerRelationconfigQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerRelationconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 允许所有小程序跳转
        /// </summary>
        [XmlElement("unlimited")]
        public bool Unlimited { get; set; }

        /// <summary>
        /// 互跳白名单列表
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("mini_app_relation_item_vo")]
        public List<MiniAppRelationItemVo> WhiteList { get; set; }
    }
}
