using MediatR;
using System;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery : IRequest<NoteDetailsVM>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
