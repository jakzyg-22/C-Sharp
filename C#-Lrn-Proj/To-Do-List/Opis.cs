namespace To_Do_List;

public class task_of
    {
        public string Description { get; set; }
        public bool Done { get; set; }

        public task_of(string opis)
        {
            this.Description = opis;
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
    