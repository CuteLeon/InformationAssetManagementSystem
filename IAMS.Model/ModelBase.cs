using System;

namespace IAMS.Model
{
    /* TODO: 多类型实体的属性与界面联动方案：
     * 遍历实体类型的公开属性
     *     为属性创建界面控件
     *     创建表达式树，绑定控件值与对象属性
     *     编译表达式树
     *  保存时，执行表达式树
     */

    /// <summary>
    /// 模型基类
    /// </summary>
    public abstract class ModelBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
    }
}
