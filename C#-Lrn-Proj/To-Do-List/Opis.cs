namespace To_Do_List;

public class task_of
    {
        public string Description { get; set; }
        public bool Done { get; set; }

        public task_of(string description)
        {
            this.Description = description;
            Done = false; // domyślnie zadanie jest niewykonane
        }

        public void MarkAsDone()
        {
            Done = true;
        }

        public override string ToString()
        {
            string status = Done ? "[✓]" : "[ ]";
            return $"{status} {Description}";
        }
    }
    
