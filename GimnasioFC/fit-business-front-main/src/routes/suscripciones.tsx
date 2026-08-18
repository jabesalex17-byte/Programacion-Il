import { createFileRoute } from "@tanstack/react-router";
import { AppShell } from "@/components/gym/AppShell";
import { ResourceManager, type FieldDef } from "@/components/gym/ResourceManager";
import { subscriptionsApi, type Subscription } from "@/lib/gym-api";

export const Route = createFileRoute("/suscripciones")({
  head: () => ({
    meta: [
      { title: "Suscripciones | GimnasioFC" },
      { name: "description", content: "Membresías, vigencias y estado de las suscripciones." },
      { property: "og:title", content: "Suscripciones | GimnasioFC" },
      { property: "og:description", content: "Controla las membresías activas del gimnasio." },
    ],
  }),
  component: Page,
});

const fields: FieldDef<Subscription>[] = [
  { key: "memberId", label: "ID Miembro", type: "number" },
  { key: "membershipId", label: "ID Membresía", type: "number" },
  { key: "fechaInicio", label: "Fecha inicio", type: "date" },
  { key: "fechaFin", label: "Fecha fin", type: "date" },
  { key: "activa", label: "Activa", type: "boolean" },
];

function Page() {
  return (
    <AppShell>
      <ResourceManager<Subscription>
        title="Suscripciones"
        description="Membresías vigentes y su periodo de validez."
        queryKey="Subscription"
        api={subscriptionsApi}
        fields={fields}
        searchKeys={["memberId", "membershipId"]}
      />
    </AppShell>
  );
}
