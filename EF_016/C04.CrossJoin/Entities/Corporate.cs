﻿namespace C04.CrossJoin.QueryData.Entities
{
    public class Corporate : Participant
    {
        public string? Company { get; set; }
        public string? JobTitle { get; set; }

        public override string ToString()
        {
            return $"{Id}  | {LName}, {FName} | ({JobTitle}) at {Company}";
        }
    }
}
