<template>
  <div>
    <v-row>
      <p class="font-weight-bold">All Events</p>
    </v-row>
    <!-- Event List -->
    <v-row v-for="(event, index) in events" :key="index">
      <v-col cols="3">
        <event-card :event-item="event" />
      </v-col>
    </v-row>
  </div>
</template>

<script>
import EventCard from './components/EventCard.vue'
import { ref, onMounted } from 'vue'
import axios from 'axios'

export default {
  components: {
    EventCard
  },

  setup() {
    const events = ref([])

    const fetchInitial = async () => {
      const pageSize = 10
      const pageIndex = 1
      const eventResponse = await axios.get(
        `http://localhost:4001/api/v1/event/${pageSize}/${pageIndex}`
      )
      events.value = eventResponse.data
      console.log(eventResponse.data)
    }

    onMounted(async () => {
      await fetchInitial()
    })

    return {
      events
    }
  }
}
</script>
