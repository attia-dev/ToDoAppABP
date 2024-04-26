import type { TodoItemDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TodoService {
  apiName = 'Default';
  

  create = (text: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, TodoItemDto>({
      method: 'POST',
      url: '/api/app/todo',
      params: { text },
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/todo/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, TodoItemDto[]>({
      method: 'GET',
      url: '/api/app/todo',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
