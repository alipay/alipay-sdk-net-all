using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosDishQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑盒子菜品的详情
        /// </summary>
        [XmlElement("pos_dish_qry_model")]
        public PosDishQryModel PosDishQryModel { get; set; }
    }
}
