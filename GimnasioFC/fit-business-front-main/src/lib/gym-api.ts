/**
 * Cliente HTTP para la API GimnasioFC (.NET)
 * Endpoints: /api/Member, /api/Coach, /api/Employee, /api/Subscription
 */

const BASE_URL = "http://localhost:5049";

export function getApiUrl(): string {
  return BASE_URL;
}

export interface BasePerson {
  id: number;
  firstName: string;
  lastName: string;
  age: number;
  email: string;
  phoneNumber: string;
}

export interface Member extends BasePerson {
  registrationDate: string;
  active: boolean;
}

export interface Coach extends BasePerson {
  specialty: string;
  salary: number;
  active: boolean;
}

export interface Employee extends BasePerson {
  jobTitle: string;
  salary: number;
  hireDate: string;
  isActive: boolean;
}

export interface Subscription {
  id: number;
  memberId: number;
  membershipId: number;
  fechaInicio: string;
  fechaFin: string;
  activa: boolean;
}

async function request<T>(path: string, init?: RequestInit): Promise<T> {
  const res = await fetch(`${getApiUrl()}${path}`, {
    ...init,
    headers: { "Content-Type": "application/json", ...(init?.headers || {}) },
  });
  if (!res.ok) {
    const text = await res.text().catch(() => "");
    throw new Error(`${res.status} ${res.statusText}${text ? ` — ${text}` : ""}`);
  }
  if (res.status === 204) return undefined as T;
  const body = await res.text();
  return (body ? JSON.parse(body) : undefined) as T;
}

/** CRUD genérico sobre un controlador de la API */
export function createResourceApi<T extends { id: number }>(controller: string) {
  return {
    list: () => request<T[]>(`/api/${controller}`),
    get: (id: number) => request<T>(`/api/${controller}/${id}`),
    create: (data: Partial<T>) =>
      request<void>(`/api/${controller}`, { method: "POST", body: JSON.stringify(data) }),
    update: (id: number, data: Partial<T>) =>
      request<void>(`/api/${controller}/${id}`, {
        method: "PUT",
        body: JSON.stringify({ ...data, id }),
      }),
    // El controlador expone DELETE con el id como query string
    remove: (id: number) =>
      request<void>(`/api/${controller}?id=${id}`, { method: "DELETE" }),
  };
}

export const membersApi = createResourceApi<Member>("Member");
export const coachesApi = createResourceApi<Coach>("Coach");
export const employeesApi = createResourceApi<Employee>("Employee");
export const subscriptionsApi = createResourceApi<Subscription>("Subscription");
