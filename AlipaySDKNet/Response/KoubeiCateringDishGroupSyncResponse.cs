using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishGroupSyncResponse : AopResponse
    {
        /// <summary>
        /// 组模型
        /// </summary>
        [XmlElement("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }
    }
}
