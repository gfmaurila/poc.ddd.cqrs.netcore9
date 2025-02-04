﻿namespace API.Clinic.Core.Feature.Domain.Exemple.Models;

public record AuthExempleCreateUpdateDeleteModel(DateTime? DtInsert,
                                                  int? DtInsertId,
                                                  DateTime? DtUpdate,
                                                  int? DtUpdateId,
                                                  DateTime? DtDelete,
                                                  int? DtDeleteId);
