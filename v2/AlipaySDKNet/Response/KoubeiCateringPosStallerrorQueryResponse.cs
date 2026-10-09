using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosStallerrorQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStallerrorQueryResponse : AopResponse
    {
        /// <summary>
        /// 档口异常菜品集合模型
        /// </summary>
        [XmlElement("error_dish_stall_entity")]
        public ErrorDishStallEntity ErrorDishStallEntity { get; set; }
    }
}
