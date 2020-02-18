using System.Xml.Serialization;

namespace Aop.Api.Response
{
    public class AlipaySecurityLcTestQueryResponse : AopResponse
    {
        [XmlElement("shop_id")]
        public string ShopId { get; set; }


        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
