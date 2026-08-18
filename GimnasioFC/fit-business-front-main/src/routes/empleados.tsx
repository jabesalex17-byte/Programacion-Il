import { createFileRoute } from "@tanstack/react-router";
import { AppShell } from "@/components/gym/AppShell";
import { ResourceManager, type FieldDef } from "@/components/gym/ResourceManager";
import { employeesApi, type Employee } from "@/lib/gym-api";

export const Route = createFileRoute("/empleados")({
  head: () => ({
    meta: [
      { title: "Empleados | GimnasioFC" },
      { name: "description", content: "Personal del gimnasio: puestos, salarios y altas." },
      { property: "og:title", content: "Empleados | GimnasioFC" },
      { property: "og:description", content: "Gestiona al personal del gimnasio." },
    ],
  }),
  component: Page,
});

const fields: FieldDef<Employee>[] = [
  { key: "firstName", label: "Nombre", type: "text" },
  { key: "lastName", label: "Apellido", type: "text" },
  { key: "age", label: "Edad", type: "number" },
  { key: "email", label: "Email", type: "email" },
  { key: "phoneNumber", label: "Teléfono", type: "text" },
  { key: "jobTitle", label: "Puesto", type: "text" },
  { key: "salary", label: "Salario", type: "number" },
  { key: "hireDate", label: "Fecha de ingreso", type: "date" },
  { key: "isActive", label: "Activo", type: "boolean" },
];

function Page() {
  return (
    <AppShell>
      <ResourceManager<Employee>
        title="Empleados"
        description="Personal administrativo y operativo."
        queryKey="Employee"
        api={employeesApi}
        fields={fields}
        searchKeys={["firstName", "lastName", "jobTitle"]}
      />
    </AppShell>
  );
}
