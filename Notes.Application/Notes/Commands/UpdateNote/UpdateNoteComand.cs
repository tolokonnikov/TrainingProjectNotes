﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteComand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
