﻿import documentMetadata = require("models/documentMetadata");

class customFunctions {
    functions: string;
    __metadata: documentMetadata;

    constructor(dto?: customFunctionsDto) {
        if (!dto) {
            dto = {
                Functions: ""
            };
            this.__metadata = new documentMetadata();
        } else {
            this.__metadata = new documentMetadata(dto["@metadata"]);
        }

        this.functions = dto.Functions;
    }

    toDto(includeMetadata?: boolean): customFunctionsDto {
        var dto: customFunctionsDto = {
            Functions: this.functions
        };

        if (includeMetadata && this.__metadata) {
            dto['@metadata'] = this.__metadata.toDto();
        }
        return dto;
    }
}

export = customFunctions;