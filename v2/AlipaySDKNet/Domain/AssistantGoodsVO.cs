using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantGoodsVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantGoodsVO : AopObject
    {
        /// <summary>
        /// 人群code，需要通过棋盘人群创建接口<a href="https://opendocs.alipay.com/open/09c10677_alipay.marketing.qipan.crowdoperation.create?pathHash=3d8bad63">https://opendocs.alipay.com/open/09c10677_alipay.marketing.qipan.crowdoperation.create?pathHash=3d8bad63</a>创建并获取返回crowd_code作为这个地方传的人群code参数
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 商品Id。传入商品id后可支持在群内发商品消息。请先通过小程序商品创建接口<a href="https://opendocs.alipay.com/mini/4880cf68_alipay.open.app.item.create?scene=common&pathHash=250eb20d"> https://opendocs.alipay.com/mini/4880cf68_alipay.open.app.item.create?scene=common&pathHash=250eb20d</a> 或小程序本地商品创建接口<a href="https://opendocs.alipay.com/mini/4aa8dac1_alipay.open.app.localitem.create?pathHash=9bdb074d&highlight_field=item_id">https://opendocs.alipay.com/mini/4aa8dac1_alipay.open.app.localitem.create?pathHash=9bdb074d&highlight_field=item_id</a>创建商品，并获取item_id 平台侧商品ID作为这个入参的值。
        /// </summary>
        [XmlElement("goods_item_id")]
        public string GoodsItemId { get; set; }

        /// <summary>
        /// 商品所属的小程序appId
        /// </summary>
        [XmlElement("related_app_id")]
        public string RelatedAppId { get; set; }
    }
}
