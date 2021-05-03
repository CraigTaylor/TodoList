namespace TodoList.Data
{
    /// <summary>
    /// 待办事项
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// 事项名称
        /// </summary>
        /// <value></value>
        public string Title { get; set; }

        /// <summary>
        /// 事项是否已完成
        /// </summary>
        /// <value></value>
        public bool IsDone { get; set; }
    }
}