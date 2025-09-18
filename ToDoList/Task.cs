class Task
{
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Task(string desc)
        {
            this.Description = desc;
            this.IsCompleted = false;
        }

        
}