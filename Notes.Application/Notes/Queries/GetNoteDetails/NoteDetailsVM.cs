﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;
using System;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class NoteDetailsVM : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVM>()
                .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.LastModifiedDate,
                opt => opt.MapFrom(note => note.LastModifiedDate))
                .ForMember(noteVm => noteVm.CreationDate,
                opt => opt.MapFrom(note => note.CreationDate));
        }
    }
}
