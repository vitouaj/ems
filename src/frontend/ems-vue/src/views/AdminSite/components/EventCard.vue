<template>
  <v-card class="Event_card pa-3" color="#d9d9d970" @click="onClickCard">
    <v-row>
      <v-col cols="12" class="d-flex justify-end align-center">
        <v-chip class="rounded-lg" size="x-small" variant="elevated" color="#7CB518">
          <v-icon size="small">mdi-alarm</v-icon><span>start at {{ eventItem.startedDate }}</span>
        </v-chip>
      </v-col>
      <v-col cols="12" class="pb-0">
        <v-img
          src="https://buffer.com/library/content/images/2023/10/free-images.jpg"
          max-height="150"
        ></v-img>
      </v-col>
      <v-col cols="12" class="pb-0">
        <h3 class="font-weight-bold text-uppercase" style="color: #004b8d">{{ eventItem.name }}</h3>
      </v-col>
      <v-col cols="12" class="pb-0">
        <p>
          <v-icon color="#004B8D">mdi-map-marker-radius-outline</v-icon>{{ eventItem.venue.name }}
        </p>
      </v-col>
      <v-col cols="12" class="pb-0">
        <p>
          <v-icon color="#004B8D">mdi-account-multiple</v-icon>
          {{ eventItem.numberOfParticipant }} Subscribes
        </p>
      </v-col>
      <v-col cols="12">
        <v-chip class="rounded-lg" size="x-small" variant="elevated" color="#FF7F00">
          <p>{{ eventItem.category.name }}</p>
        </v-chip>
      </v-col>
    </v-row>
  </v-card>
</template>

<script>
export default {
  data() {
    return {
      e_Time: '8.30',
      e_Title: 'Event Name sample',
      e_location: 'event_location',
      e_participate: 55,
      e_tag: 'education'
    }
  },
  methods: {
    onClickCard() {
      this.$router.push(`/admin/detail-screen/${this.eventItem.id}`)
    }
  },
  props: {
    eventItem: {
      type: Object,
      required: true
    }
  }
}
</script>

<style>
.Event_card {
  border: 1px solid rgba(255, 127, 0, 0.2);
  box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
}
</style>
