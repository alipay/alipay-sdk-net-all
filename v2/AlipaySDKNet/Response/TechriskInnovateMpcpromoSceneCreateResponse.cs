using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneCreateResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoSceneCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回非法商品数据列表，该商品未导入到小程序云，创建场景时不能被选择。
        /// </summary>
        [XmlArray("illegal_goods_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalGoodsList { get; set; }

        /// <summary>
        /// 创建场景后，返回新创建的场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
