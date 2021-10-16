﻿using MediatR;
using Notes.Application.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exceptions;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryHandler
        : IRequestHandler<GetNoteDetailsQuery, NoteDetailsVM>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetNoteDetailsQueryHandler(INotesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<NoteDetailsVM> Handle(GetNoteDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes.FirstOrDefaultAsync(note => note.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note), request.Id);
            }

            return _mapper.Map<NoteDetailsVM>(entity);
        }
    }
}
